using System;

namespace StartProjectGuide.Business.Attributes
{
    /// <summary>
    ///     Used for auto populating fields when translating
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class AutoPopulateLanguageBranchAttribute : Attribute
    {
    }
}