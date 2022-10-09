// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace Antlr4Ast;

public class ImportNameSyntax : SyntaxNode
{
    public ImportNameSyntax(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public string? Value { get; set; }

    protected override void ToTextImpl(StringBuilder builder, FormattingOptions options)
    {
        builder.Append(Name);
        if (Value != null) builder.Append(" = ").Append(Name);
    }
}