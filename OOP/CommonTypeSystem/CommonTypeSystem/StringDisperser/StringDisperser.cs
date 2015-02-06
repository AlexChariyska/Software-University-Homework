namespace StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StringDisperser : IComparable<StringDisperser>, IEnumerable
    {
        private string[] words;
        public StringDisperser(params string[] words)
        {
            this.Words = words;
        }

        public string[] Words
        {
            get { return this.words; }

            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentNullException("Words array can't be empty");
                }

                this.words = value;
            }
        }


        public static bool operator ==(StringDisperser word1, StringDisperser word2)
        {
            return StringDisperser.Equals(word1, word2);
        }

        public static bool operator !=(StringDisperser word1, StringDisperser word2)
        {
            return !(StringDisperser.Equals(word1, word2));
        }

        public override int GetHashCode()
        {
            int result = this.Words.GetHashCode();
            return result;
        }
        public override string ToString()
        {
            return String.Join(", ", this.Words);
        }
        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;
            if (stringDisperser == null)
            {
                return false;
            }

            if (this.Words.Equals(stringDisperser))
            {
                return false;
            }

            return true;
        }

        public object Clone()
        {
            string[] newWords = new string[this.Words.Length];
            for (int i = 0; i < newWords.Length; i++)
            {
                newWords[i] = this.Words[i];
            }

            return new StringDisperser(newWords);
        }

        public int CompareTo(StringDisperser otherWords)
        {
            string firstString = String.Join("", this.Words);
            string secondString = String.Join("", otherWords);
            return firstString.CompareTo(secondString);
        }

        public IEnumerator GetEnumerator()
        {
            string wholeString = String.Join("", this.Words);
            for (int i = 0; i < wholeString.Length; i++)
            {
                yield return wholeString[i];
            }
        }
    }
}
