// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace Antlr4Ast;

public sealed class BlockSyntax : AlternativeListSyntax
{
    public override void ToText(StringBuilder builder)
    {
        if (IsNot) builder.Append("~ ");
        else if (Label != null) builder.Append(Label).Append('=');
        builder.Append("( ");
        base.ToText(builder);
        builder.Append(" )");
        builder.Append(Suffix.ToText());
    }
}