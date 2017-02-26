namespace CSharpCodeChallenges.UserInput
{
    using System.Text.RegularExpressions;

    public class TextInput
    {
        /// <summary>
        /// The resource
        /// </summary>
        private string res = string.Empty;

        /// <summary>
        /// Adds the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public virtual void Add(char c)
        {
            if (!Regex.IsMatch(c.ToString(), "[0-9]"))
            {
                this.res += c;
            }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns></returns>
        public string GetValue()
        {
            return this.res;
        }
    }
}
