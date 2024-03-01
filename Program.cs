using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string H = "ABCxyz";
            EnigmaMachine hallo = new EnigmaMachine(H);
;
            
        }
    }
}


public class EnigmaMachine

{

    public EnigmaMachine(string Input) { }


    internal int[] Walze_I = new int[] { -4, -9, -10, -2, -7, -1, 3, -9, -13, -16, -3, -8, -2, -9, -10, 8, -7, -3, 0, 4, 20, 13, 21, 6, 22, 16 };
    internal int[] Walze_II = new int[] { -9, -2, -8, -15, -4, -12, -14, -16, 7, -2, 3, -11, -7, 1, 12, -1, 10, -8, 5, 4, -4, 16, 1, 9, 20, 25 };
    internal int[] Walze_III = new int[] { -1, -2, -3, -4, -5, -6, 4, -8, -9, -10, -13, -10, -13, 0, -10, 11, 8, -5, 12, 19, 10, 9, 2, 5, 8, 11 };
    internal int[] Walze_IV = new int[] { -4, -17, -12, -18, -11, -20, -3, 7, -16, -7, -10, 3, -5, 6, -9, 4, 3, 12, -1, 13, 10, 18, 20, 11, 2, 24 };
    internal int[] Walze_V = new int[] { -21, -24, 1, -14, -2, -3, -13, -17, -12, -6, -8, 8, -1, 6, 3, -8, 16, -5, 6, 10, 4, 7, 17, 19, 22, 15 };
    internal int[] UMKWalze_A = new int[] { -4, -8, -10, -22, 4, -6, -18, -16, -13, 8, -12, 6, 10, -4, -2, -5, 2, 4, -1, 1, 5, 13, 12, 16, 18, 22 };
    internal int[] UMKWalze_B = new int[] { -24, -16, -18, -4, -12, -13, -5, 4, -7, -14, -3, 5, -2, 3, 2, 7, 12, 16, 13, -6, 18, -1, 1, 14, 24, 6 };
    internal int[] UMKWalze_C = new int[] { -5, -20, -13, -6, -4, 5, -8, -17, 4, 6, -7, -14, -11, -9, 8, 13, -3, 7, -2, 3, 2, 20, 9, 11, 17, 14 };

    public ulong CounterOfWalze;
    // private int[] Inputindearray = ConvertLetterToIndex();
    //public string Output { get { return ConvertIndexToLetter(Inputindearray); } }

    public static int[] ConvertLetterToIndex(string StringInput)
    {
        char[] ArrayOfStringInput = StringInput.Replace(" ", "").ToUpper().ToArray();
        int[] ArrayOfIndexOutput = new int[ArrayOfStringInput.Length];

        for (int i = 0; i < ArrayOfStringInput.Length; i++)
        {
            ArrayOfIndexOutput[i] = ArrayOfStringInput[i] - 'A';
        }

        return ArrayOfIndexOutput;
    }
    private string ConvertIndexToLetter(int[] Arrayinput)
    {
        char[] CharArrayOutput = new char[Arrayinput.Length];
        for (int i = 0; i < Arrayinput.Length; i++)
        {
            CharArrayOutput[i] = (char)(Arrayinput[i] + 'A');
        }
        return new string(CharArrayOutput);
    }

    public void encrypting(Array Walzebosition1)
    {
        Modulo i = new Modulo(1, 25);
        int j = -10000;
        i += 1;
    }
    internal abstract class Walze
    {
        internal Walze NextWalze;
        private int[] inputWalze;

        internal abstract bool CanBeAppend { get; }

        protected Walze()
        {
        }

        public void AppendWalze(Walze addedWalze)
        {
            if (CanBeAppend)
            {
                if (NextWalze != null)
                {
                    NextWalze.AppendWalze(addedWalze);
                }
                else
                {
                    NextWalze = addedWalze;
                }
            }
        }

        public virtual int calculate(Walze input, int inputValue)
        {
            inputValue = input.inputWalze[inputValue];
            if (inputValue >= 0)
            {
                inputValue %= input.inputWalze.Length;
            }
            else
            {
                inputValue = inputValue % input.inputWalze.Length + input.inputWalze.Length;
            }
            if (NextWalze != null)
            {
                inputValue = calculate(NextWalze, inputValue);
            }
            return inputValue;
        }
    }

    internal class HistoricalUKW : Walze
    {
        private int[] inputWalze;

        internal HistoricalUKW(int[] inputWalze)
        {
            this.inputWalze = inputWalze;
        }

        internal override bool CanBeAppend => false;

        public override int calculate(Walze input, int inputValue)
        {
            return base.calculate(input, inputValue);
        }
    }

    internal class HistoricalWalze : Walze
    {
        private int counter;
        private int[] inputWalze;
        int movePositionIfHit;

        internal HistoricalWalze(int[] inputWalze, int movePosition, int startingPosition = 0)
        {
            this.inputWalze = inputWalze;
            counter = startingPosition;
            movePositionIfHit = movePosition;
        }

        internal override bool CanBeAppend => true;

        public override int calculate(Walze input, int inputValue)
        {
            return base.calculate(input, inputValue);
        }

        public void Mover()
        {
            counter = (counter % inputWalze.Length + inputWalze.Length) % inputWalze.Length;
            if (counter == movePositionIfHit && NextWalze != null)
            {
                NextWalze.Mover();
                counter++;
            }
            else
            {
                counter++;
            }
        }
    }
}



public readonly struct Modulo
{
    public Modulo(int value, int modulo) {
        _Modulo = (modulo > 0) ? modulo : -modulo;
        _Value = value % _Modulo;
        if (_Value < 0) _Value += _Modulo;
    }

    private readonly int _Value;
    private readonly int _Modulo;

    public static implicit operator int(Modulo modulo) {
        return modulo._Value;
    }
    public static Modulo operator + (Modulo modulo, int shift)
    {
        return new Modulo(modulo._Value + shift, modulo._Modulo);
    }
    public static Modulo operator - (Modulo modulo, int shift)
    {
        return new Modulo(modulo._Value - shift, modulo._Modulo);
    }
    public static Modulo operator * (Modulo modulo, int factor)
    {
        return new Modulo(modulo._Value * factor, modulo._Modulo);
    }
}


