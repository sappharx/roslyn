// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Xunit;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Parsing
{
    public class ValueTupleTests : ParsingTests
    {
        protected override SyntaxTree ParseTree(string text, CSharpParseOptions options)
        {
            return SyntaxFactory.ParseSyntaxTree(text, options: options);
        }
        
        [Fact]
        public void SimpleTuple()
        {
            var tree = UsingTree(@"
class C
{
    (int, string) Foo()
    {
        return (1, ""Alice"");
    }
}");
            N(SyntaxKind.CompilationUnit);
            {
                N(SyntaxKind.ClassDeclaration);
                {
                    N(SyntaxKind.ClassKeyword);
                    N(SyntaxKind.IdentifierToken);
                    N(SyntaxKind.OpenBraceToken);
                    N(SyntaxKind.MethodDeclaration);
                    {
                        N(SyntaxKind.TupleType);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.StringKeyword);
                                }
                            }
                            N(SyntaxKind.CloseParenToken);
                        }
                        N(SyntaxKind.IdentifierToken);
                        N(SyntaxKind.ParameterList);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.CloseParenToken);
                        }
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.ReturnStatement);
                            {
                                N(SyntaxKind.ReturnKeyword);
                                N(SyntaxKind.TupleExpression);
                                {
                                    N(SyntaxKind.OpenParenToken);
                                    N(SyntaxKind.Argument);
                                    {
                                        N(SyntaxKind.NumericLiteralExpression);
                                        {
                                            N(SyntaxKind.NumericLiteralToken);
                                        }
                                    }
                                    N(SyntaxKind.CommaToken);
                                    N(SyntaxKind.Argument);
                                    {
                                        N(SyntaxKind.StringLiteralExpression);
                                        {
                                            N(SyntaxKind.StringLiteralToken);
                                        }
                                    }
                                    N(SyntaxKind.CloseParenToken);
                                }
                                N(SyntaxKind.SemicolonToken);
                            }
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                    N(SyntaxKind.CloseBraceToken);
                }
                N(SyntaxKind.EndOfFileToken);
            }
            EOF();
        }


        [Fact]
        public void LongTuple()
        {
            var tree = UsingTree(@"
class C
{
    (int, int, int, string, string, string, int, int, int) Foo()
    {
    }
}");
            N(SyntaxKind.CompilationUnit);
            {
                N(SyntaxKind.ClassDeclaration);
                {
                    N(SyntaxKind.ClassKeyword);
                    N(SyntaxKind.IdentifierToken);
                    N(SyntaxKind.OpenBraceToken);
                    N(SyntaxKind.MethodDeclaration);
                    {
                        N(SyntaxKind.TupleType);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.StringKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.StringKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.StringKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CommaToken);
                            N(SyntaxKind.TupleElement);
                            {
                                N(SyntaxKind.PredefinedType);
                                {
                                    N(SyntaxKind.IntKeyword);
                                }
                            }
                            N(SyntaxKind.CloseParenToken);
                        }
                        N(SyntaxKind.IdentifierToken);
                        N(SyntaxKind.ParameterList);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.CloseParenToken);
                        }
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                    N(SyntaxKind.CloseBraceToken);
                }
                N(SyntaxKind.EndOfFileToken);
            }
            EOF();
        }

        [Fact]
        public void TuplesInLambda()
        {
            var tree = UsingTree(@"
class C
{
    var x = ((string, string) a, (int, int) b) => { };
}");
            N(SyntaxKind.CompilationUnit);
            {
                N(SyntaxKind.ClassDeclaration);
                {
                    N(SyntaxKind.ClassKeyword);
                    N(SyntaxKind.IdentifierToken);
                    N(SyntaxKind.OpenBraceToken);
                    N(SyntaxKind.FieldDeclaration);
                    {
                        N(SyntaxKind.VariableDeclaration);
                        {
                            N(SyntaxKind.IdentifierName);
                            {
                                N(SyntaxKind.IdentifierToken);
                            }
                            N(SyntaxKind.VariableDeclarator);
                            {
                                N(SyntaxKind.IdentifierToken);
                                N(SyntaxKind.EqualsValueClause);
                                {
                                    N(SyntaxKind.EqualsToken);
                                    N(SyntaxKind.ParenthesizedLambdaExpression);
                                    {
                                        N(SyntaxKind.ParameterList);
                                        {
                                            N(SyntaxKind.OpenParenToken);
                                            N(SyntaxKind.Parameter);
                                            {
                                                N(SyntaxKind.TupleType);
                                                {
                                                    N(SyntaxKind.OpenParenToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.StringKeyword);
                                                        }
                                                    }
                                                    N(SyntaxKind.CommaToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.StringKeyword);
                                                        }
                                                    }
                                                    N(SyntaxKind.CloseParenToken);
                                                }
                                                N(SyntaxKind.IdentifierToken);
                                            }
                                            N(SyntaxKind.CommaToken);
                                            N(SyntaxKind.Parameter);
                                            {
                                                N(SyntaxKind.TupleType);
                                                {
                                                    N(SyntaxKind.OpenParenToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.IntKeyword);
                                                        }
                                                    }
                                                    N(SyntaxKind.CommaToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.IntKeyword);
                                                        }
                                                    }
                                                    N(SyntaxKind.CloseParenToken);
                                                }
                                                N(SyntaxKind.IdentifierToken);
                                            }
                                            N(SyntaxKind.CloseParenToken);
                                        }
                                        N(SyntaxKind.EqualsGreaterThanToken);
                                        N(SyntaxKind.Block);
                                        {
                                            N(SyntaxKind.OpenBraceToken);
                                            N(SyntaxKind.CloseBraceToken);
                                        }
                                    }
                                }
                            }
                        }
                        N(SyntaxKind.SemicolonToken);
                    }
                    N(SyntaxKind.CloseBraceToken);
                }
                N(SyntaxKind.EndOfFileToken);
            }
            EOF();
        }

        [Fact]
        public void TuplesWithNamesInLambda()
        {
            var tree = UsingTree(@"
class C
{
    var x = ((string a, string) a, (int, int b) b) => { };
}");
            N(SyntaxKind.CompilationUnit);
            {
                N(SyntaxKind.ClassDeclaration);
                {
                    N(SyntaxKind.ClassKeyword);
                    N(SyntaxKind.IdentifierToken);
                    N(SyntaxKind.OpenBraceToken);
                    N(SyntaxKind.FieldDeclaration);
                    {
                        N(SyntaxKind.VariableDeclaration);
                        {
                            N(SyntaxKind.IdentifierName);
                            {
                                N(SyntaxKind.IdentifierToken);
                            }
                            N(SyntaxKind.VariableDeclarator);
                            {
                                N(SyntaxKind.IdentifierToken);
                                N(SyntaxKind.EqualsValueClause);
                                {
                                    N(SyntaxKind.EqualsToken);
                                    N(SyntaxKind.ParenthesizedLambdaExpression);
                                    {
                                        N(SyntaxKind.ParameterList);
                                        {
                                            N(SyntaxKind.OpenParenToken);
                                            N(SyntaxKind.Parameter);
                                            {
                                                N(SyntaxKind.TupleType);
                                                {
                                                    N(SyntaxKind.OpenParenToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.StringKeyword);
                                                        }
                                                        N(SyntaxKind.IdentifierName);
                                                        {
                                                            N(SyntaxKind.IdentifierToken);
                                                        }
                                                    }
                                                    N(SyntaxKind.CommaToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.StringKeyword);
                                                        }
                                                    }
                                                    N(SyntaxKind.CloseParenToken);
                                                }
                                                N(SyntaxKind.IdentifierToken);
                                            }
                                            N(SyntaxKind.CommaToken);
                                            N(SyntaxKind.Parameter);
                                            {
                                                N(SyntaxKind.TupleType);
                                                {
                                                    N(SyntaxKind.OpenParenToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.IntKeyword);
                                                        }
                                                    }
                                                    N(SyntaxKind.CommaToken);
                                                    N(SyntaxKind.TupleElement);
                                                    {
                                                        N(SyntaxKind.PredefinedType);
                                                        {
                                                            N(SyntaxKind.IntKeyword);
                                                        }
                                                        N(SyntaxKind.IdentifierName);
                                                        {
                                                            N(SyntaxKind.IdentifierToken);
                                                        }
                                                    }
                                                    N(SyntaxKind.CloseParenToken);
                                                }
                                                N(SyntaxKind.IdentifierToken);
                                            }
                                            N(SyntaxKind.CloseParenToken);
                                        }
                                        N(SyntaxKind.EqualsGreaterThanToken);
                                        N(SyntaxKind.Block);
                                        {
                                            N(SyntaxKind.OpenBraceToken);
                                            N(SyntaxKind.CloseBraceToken);
                                        }
                                    }
                                }
                            }
                        }
                        N(SyntaxKind.SemicolonToken);
                    }
                    N(SyntaxKind.CloseBraceToken);
                }
                N(SyntaxKind.EndOfFileToken);
            }
            EOF();
        }

        [Fact]
        public void TupleInParameters()
        {
            var tree = UsingTree(@"
class C
{
    void Foo((int, string) a)
    {
    }
}");
            N(SyntaxKind.CompilationUnit);
            {
                N(SyntaxKind.ClassDeclaration);
                {
                    N(SyntaxKind.ClassKeyword);
                    N(SyntaxKind.IdentifierToken);
                    N(SyntaxKind.OpenBraceToken);
                    N(SyntaxKind.MethodDeclaration);
                    {
                        N(SyntaxKind.PredefinedType);
                        {
                            N(SyntaxKind.VoidKeyword);
                        }
                        N(SyntaxKind.IdentifierToken);
                        N(SyntaxKind.ParameterList);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.Parameter);
                            {
                                N(SyntaxKind.TupleType);
                                {
                                    N(SyntaxKind.OpenParenToken);
                                    N(SyntaxKind.TupleElement);
                                    {
                                        N(SyntaxKind.PredefinedType);
                                        {
                                            N(SyntaxKind.IntKeyword);
                                        }
                                    }
                                    N(SyntaxKind.CommaToken);
                                    N(SyntaxKind.TupleElement);
                                    {
                                        N(SyntaxKind.PredefinedType);
                                        {
                                            N(SyntaxKind.StringKeyword);
                                        }
                                    }
                                    N(SyntaxKind.CloseParenToken);
                                }
                                N(SyntaxKind.IdentifierToken);
                            }
                            N(SyntaxKind.CloseParenToken);
                        }
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                    N(SyntaxKind.CloseBraceToken);
                }
                N(SyntaxKind.EndOfFileToken);
            }
            EOF();
        }
    }
}
