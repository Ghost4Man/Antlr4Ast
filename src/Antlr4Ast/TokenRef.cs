// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace Antlr4Ast;

/// <summary>
/// An element used in a lexer rule that defines a reference to lexer token (e.g MY_TOKEN).
/// </summary>
public sealed class TokenRef : SyntaxElement
{
    /// <summary>
    /// Creates a new instance of this object.
    /// </summary>
    /// <param name="name">The name of the referenced token.</param>
    public TokenRef(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Gets or sets the name of the referenced token.
    /// </summary>
    public string Name { get; set; }

    /// <inheritdoc />
    public override IEnumerable<SyntaxNode> Children()
    {
        if (ElementOptions is not null) yield return ElementOptions;
    }

    /// <inheritdoc />
    public override void Accept(GrammarVisitor visitor)
    {
        visitor.Visit(this);
    }

    /// <inheritdoc />
    public override TResult? Accept<TResult>(GrammarVisitor<TResult> transform) where TResult : default
    {
        return transform.Visit(this);
    }

    /// <inheritdoc />
    protected override void ToTextImpl(StringBuilder builder, AntlrFormattingOptions options)
    {
        builder.Append(Name);
    }
}