namespace CSharpCodeChallenges.UserInput
{
    using System.Text.RegularExpressions;

    public class NumberInput : TextInput
    {
        /// <summary>
        /// The resource
        /// </summary>
        private string res = string.Empty;

        /// <summary>
        /// Adds the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public override void Add(char c)
        {
            if (Regex.IsMatch(c.ToString(), "[0-9]"))
            {
                this.res += c;
            }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns></returns>
        public new string GetValue()
        {
            return this.res;
        }
    }
}
