// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Templates.Test.Helpers
{
    internal static class ErrorMessages
    {
        public static string GetErrorMessage(string step, Project project, ProcessEx processResult)
        {
            return $@"Project {project.ProjectArguments} failed to {step}.
{processResult.GetFormattedOutput()}";
        }
    }
}
