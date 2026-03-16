using FFmpeg.AutoGen.ClangMacroParser.Expressions;

namespace FFmpeg.AutoGen.ClangMacroParser.Test
{
    [TestClass]
    public class ParserTest
    {
        private void CastExpression<T>(IExpression e, params Action<T>[] tests) where T : IExpression
        {
            if (e is T) tests.ToList().ForEach(test => test((T)e));
            Assert.IsInstanceOfType(e, typeof(T));
        }

        [TestMethod]
        public void String()
        {
            CastExpression<ConstantExpression>(Parser.Parse("\"abc\""), x => Assert.AreEqual("abc", x.Value));
        }

        [TestMethod]
        public void Char()
        {
            CastExpression<ConstantExpression>(Parser.Parse("\'a\'"), x => Assert.AreEqual('a', x.Value));
        }

        [TestMethod]
        public void Number()
        {
            CastExpression<ConstantExpression>(Parser.Parse("0"), x => Assert.AreEqual(0, x.Value)); // unit
            CastExpression<ConstantExpression>(Parser.Parse("0.23"), x => Assert.AreEqual(0.23d, x.Value));
            CastExpression<ConstantExpression>(Parser.Parse("1.23d"), x => Assert.AreEqual(1.23d, x.Value));
            CastExpression<ConstantExpression>(Parser.Parse("1.23f"), x => Assert.AreEqual(1.23f, x.Value));
            CastExpression<ConstantExpression>(Parser.Parse("0.23"), x => Assert.AreEqual(0.23d, x.Value));
            CastExpression<ConstantExpression>(Parser.Parse("1.23d"), x => Assert.AreEqual(1.23d, x.Value));
            CastExpression<ConstantExpression>(Parser.Parse("1.23f"), x => Assert.AreEqual(1.23f, x.Value));
            CastExpression<ConstantExpression>(Parser.Parse("0x0123456789ABCDEF"), x => Assert.AreEqual(0x0123456789ABCDEF, x.Value)); // long
            CastExpression<ConstantExpression>(Parser.Parse("0x80000000"), x => Assert.AreEqual(0x80000000, x.Value)); // unit
            CastExpression<ConstantExpression>(Parser.Parse("0x8000000000000000ULL"), x => Assert.AreEqual(0x8000000000000000UL, x.Value)); // unit
        }

        [TestMethod]
        public void Unary()
        {
            var e = Parser.Parse(@"(-(1))");
            CastExpression<UnaryExpression>(e,
                x =>
                {
                    Assert.AreEqual(OperationType.Subtract, x.OperationType);
                    Assert.IsInstanceOfType(x.Operand, typeof(ConstantExpression));
                });
        }

        [TestMethod]
        public void CastThenBinary()
        {
            var e = Parser.Parse(@"((unsigned)(1 - 2))");
            CastExpression<CastExpression>(e,
                x =>
                {
                    Assert.AreEqual("unsigned", x.TargetType);
                    Assert.IsInstanceOfType(x.Operand, typeof(BinaryExpression));
                });
        }

        [TestMethod]
        public void BinaryThenCast()
        {
            var e = Parser.Parse(@"A | (ulong)(B)");
            CastExpression<BinaryExpression>(e,
                x =>
                {
                    Assert.AreEqual(OperationType.Or, x.OperationType);
                    CastExpression<VariableExpression>(x.Left, y => Assert.AreEqual("A", y.Name));
                    CastExpression<CastExpression>(x.Right,
                        y =>
                        {
                            Assert.AreEqual("ulong", y.TargetType);
                            CastExpression<VariableExpression>(y.Operand, z => Assert.AreEqual("B", z.Name));
                        });
                });
        }

        [TestMethod]
        public void BinaryPrecedence()
        {
            var e = Parser.Parse("1 + 2 * 3");
            CastExpression<BinaryExpression>(e,
                x =>
                {
                    Assert.AreEqual(OperationType.Add, x.OperationType);
                    CastExpression<ConstantExpression>(x.Left, y => Assert.AreEqual(1, y.Value));
                    CastExpression<BinaryExpression>(x.Right,
                        y =>
                        {
                            Assert.AreEqual(OperationType.Multiply, y.OperationType);
                            CastExpression<ConstantExpression>(y.Left, z => Assert.AreEqual(2, z.Value));
                            CastExpression<ConstantExpression>(y.Right, z => Assert.AreEqual(3, z.Value));
                        });
                });
        }

        [TestMethod]
        public void Lamda()
        {
            var e = Parser.Parse(@"MKBETAG(a, b, c, d)((d) | ((c) << 8) | ((b) << 16) | ((unsigned)(a) << 24))");
            // todo parsing is incomplete
        }

        [TestMethod]
        public void Enum()
        {
            var e = Parser.Parse("0x1UL << AVChannel.AV_CHAN_FRONT_LEFT");
            // todo finalize test
        }

        [TestMethod]
        public void TokenConcat()
        {
            var e = Parser.Parse("AV_PIX_FMT_ ## le");
            CastExpression<BinaryExpression>(e,
                x =>
                {
                    Assert.AreEqual(OperationType.TokenConcat, x.OperationType);
                    CastExpression<VariableExpression>(x.Left, y => Assert.AreEqual("AV_PIX_FMT_", y.Name));
                    CastExpression<VariableExpression>(x.Right, y => Assert.AreEqual("le", y.Name));
                });
        }

        [TestMethod]
        public void FunctionCallWithDigitPrefixedArg()
        {
            var e = Parser.Parse("AV_PIX_FMT_NE(0BGR, RGB0)");
            CastExpression<CallExpression>(e,
                x =>
                {
                    Assert.AreEqual("AV_PIX_FMT_NE", x.Name);
                    var args = x.Arguments.ToArray();
                    Assert.AreEqual(2, args.Length);
                    CastExpression<VariableExpression>(args[0], y => Assert.AreEqual("0BGR", y.Name));
                    CastExpression<VariableExpression>(args[1], y => Assert.AreEqual("RGB0", y.Name));
                });
        }

        [TestMethod]
        public void CompoundLiteral()
        {
            var e = Parser.Parse("(AVRational){1, 1000000}");
            CastExpression<CompoundLiteralExpression>(e,
                x =>
                {
                    Assert.AreEqual("AVRational", x.TypeName);
                    Assert.AreEqual(2, x.Initializer.Fields.Count);
                    Assert.IsNull(x.Initializer.Fields[0].Name);
                    CastExpression<ConstantExpression>(x.Initializer.Fields[0].Value, y => Assert.AreEqual(1, y.Value));
                    CastExpression<ConstantExpression>(x.Initializer.Fields[1].Value, y => Assert.AreEqual(1000000, y.Value));
                });
        }

        [TestMethod]
        public void InitializerList()
        {
            var e = Parser.Parse("{ 0, 2, { 3 }, 0 }");
            CastExpression<InitializerListExpression>(e,
                x =>
                {
                    Assert.AreEqual(4, x.Fields.Count);
                    CastExpression<ConstantExpression>(x.Fields[0].Value, y => Assert.AreEqual(0, y.Value));
                    CastExpression<ConstantExpression>(x.Fields[1].Value, y => Assert.AreEqual(2, y.Value));
                    CastExpression<InitializerListExpression>(x.Fields[2].Value, y => Assert.AreEqual(1, y.Fields.Count));
                    CastExpression<ConstantExpression>(x.Fields[3].Value, y => Assert.AreEqual(0, y.Value));
                });
        }

        [TestMethod]
        public void CCommentSkipping()
        {
            var e = Parser.Parse("{ /* .order */ 0, /* .nb */ 2 }");
            CastExpression<InitializerListExpression>(e,
                x =>
                {
                    Assert.AreEqual(2, x.Fields.Count);
                    CastExpression<ConstantExpression>(x.Fields[0].Value, y => Assert.AreEqual(0, y.Value));
                    CastExpression<ConstantExpression>(x.Fields[1].Value, y => Assert.AreEqual(2, y.Value));
                });
        }

        [TestMethod]
        public void NullHandling()
        {
            var e = Parser.Parse("NULL");
            CastExpression<ConstantExpression>(e, x => Assert.AreEqual(0, x.Value));
        }

        [TestMethod]
        public void DesignatedInitializer()
        {
            var e = Parser.Parse("{ .order = 0, .nb_channels = 2 }");
            CastExpression<InitializerListExpression>(e,
                x =>
                {
                    Assert.AreEqual(2, x.Fields.Count);
                    Assert.AreEqual("order", x.Fields[0].Name);
                    Assert.AreEqual("nb_channels", x.Fields[1].Name);
                    CastExpression<ConstantExpression>(x.Fields[0].Value, y => Assert.AreEqual(0, y.Value));
                    CastExpression<ConstantExpression>(x.Fields[1].Value, y => Assert.AreEqual(2, y.Value));
                });
        }
    }
}
