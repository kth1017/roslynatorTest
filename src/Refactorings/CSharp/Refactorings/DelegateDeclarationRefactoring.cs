﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Roslynator.CSharp.Refactorings
{
    internal static class DelegateDeclarationRefactoring
    {
        public static void ComputeRefactorings(RefactoringContext context, DelegateDeclarationSyntax delegateDeclaration)
        {
            if (context.IsRefactoringEnabled(RefactoringIdentifiers.AddGenericParameterToDeclaration))
                AddGenericParameterToDeclarationRefactoring.ComputeRefactoring(context, delegateDeclaration);

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.ExtractTypeDeclarationToNewFile))
                ExtractTypeDeclarationToNewFileRefactoring.ComputeRefactorings(context, delegateDeclaration);
        }
    }
}
