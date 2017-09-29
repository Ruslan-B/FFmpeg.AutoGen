using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors;
using System.Collections.Generic;
using Xunit;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Tests
{
    public class MacroExpressionParserTests
    {
        [Fact]
        public void TryParseBinaryExpression()
        {
            MacroExpressionParser parser = new MacroExpressionParser(new Dictionary<string, string>());
            Expression result;
            parser.TryParse("(1 << 4)", out result);

            var binary = Assert.IsType<Expression.Binary>(result);
            var left = Assert.IsType<Expression.Constant>(binary.Left);
            var right = Assert.IsType<Expression.Constant>(binary.Right);
            Assert.Equal("1", left.Value);
            Assert.Equal("4", right.Value);
            Assert.Equal("<<", binary.Operator);
        }
    }
}
