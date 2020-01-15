using System;

namespace Challenges.Source
{
    public class Intcode
    {
        private const int OP_CODE_ADD = 1;
        private const int OP_CODE_MULT = 2;
        private const int OP_CODE_STOP = 99;
        private const int SINGLE_CODE_LENGTH = 4;

        private readonly int[] code;

        public Intcode(int[] code)
        {
            this.code = code;
        }

        public void Execute()
        {
            if (this.code != null)
            {
                for (int k = 0; k < this.code.Length / SINGLE_CODE_LENGTH; k++)
                {
                    int index = 4 * k;
                    int opCode = this.code[index];
                    int firstArgIndex = this.code[index + 1];
                    int secondArgIndex = this.code[index + 2];
                    int resultIndex = this.code[index + 3];

                    switch (opCode)
                    {
                        case OP_CODE_ADD:
                            this.code[resultIndex] = this.code[firstArgIndex] + this.code[secondArgIndex];
                            break;

                        case OP_CODE_MULT:
                            this.code[resultIndex] = this.code[firstArgIndex] * this.code[secondArgIndex];
                            break;

                        case OP_CODE_STOP:
                            return;

                        default:
                            throw new NotSupportedException("The Unknown OP-Code " + opCode + " was found at position " + index);
                    }
                }
            }
        }

        public int Get(int index)
        {
            if (this.code.Length > index)
            {
                return this.code[index];
            }

            return -1;
        }

        public bool Replace(int index, int element)
        {
            if (this.code.Length > index)
            {
                this.code[index] = element;
                return true;
            }

            return false;
        }
    }
}
