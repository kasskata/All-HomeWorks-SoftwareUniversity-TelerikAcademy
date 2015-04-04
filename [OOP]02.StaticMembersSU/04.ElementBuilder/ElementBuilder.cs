namespace _04.ElementBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ElementBuilder
    {
        private string element;
        private List<string> attributes = new List<string>();
        private List<string> content = new List<string>();
        private string usedTag = string.Empty;

        public ElementBuilder(string newElement)
        {
            this.Element = newElement;
            this.usedTag = string.Format("</{0}>", newElement);
        }

        public string Element
        {
            get
            {
                if (string.IsNullOrEmpty(this.element))
                {
                    throw new ArgumentNullException("Invalid/Null Tag");
                }

                return this.element;
            }

            set
            {
                this.element = value;
            }
        }

        public static string operator *(ElementBuilder a, int num)
        {
            StringBuilder multy = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                multy.Append(a);
            }

            return multy.ToString();
        }

        public void AddAtribute(string attribute, string value)
        {
            this.attributes.Add(string.Format("{0}=\"{1}\" ", attribute, value));
        }

        public void AddContent(string text)
        {
            this.content.Add(string.Format(">{0}{1}", text, this.usedTag));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("<{0} ", this.Element));

            foreach (var i in this.attributes)
            {
                output.Append(i);
            }

            foreach (var i in this.content)
            {
                output.Append(i);
            }

            return output.ToString();
        }
    }
}