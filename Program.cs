using System.Collections.ObjectModel;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enigma test = new Enigma("XEFFQ", HistorsicheReflektoren.UKW_A);
            Console.WriteLine(test.Output);
        }
    }
    public class Enigma
    {
        private int[] inputOfEnigma;
        private HistorsicheReflektoren Historische_UKW;
        public string Output;

        public Enigma(string input, HistorsicheReflektoren UKW)
        {
            this.inputOfEnigma = ConvertLetterToIndex(input);
            this.Historische_UKW = UKW;
            this.Output = rechnen(inputOfEnigma);
        }
        private string rechnen(int[] arrayOfStringInput)
        {
            string output;
            int[] arrayoutput = new int[arrayOfStringInput.Length];
            char[] arrayStringoutput = new char[arrayOfStringInput.Length];
            int[] permutationTable = this.Historische_UKW.permutationTable.ToArray();
            for (int i = 0; i < arrayOfStringInput.Length; i++)
            {
                arrayoutput[i] = Array.IndexOf(permutationTable, arrayOfStringInput[i]);
                arrayStringoutput[i] = NumberToLetter(arrayoutput[i]);
            }
            output = string.Join("", arrayStringoutput); 
            return output;
        }
        private static char NumberToLetter(int num)
        {
            return (char)('A' + num);
        }
        protected static int[] ConvertLetterToIndex(string stringInput)
        {
            char[] arrayOfStringInput = stringInput.Replace(" ", "").ToUpper().ToArray();
            int[] arrayOfIndexOutput = new int[arrayOfStringInput.Length];
            for (int i = 0; i < arrayOfStringInput.Length; i++)
            {
                arrayOfIndexOutput[i] = arrayOfStringInput[i] - 'A';
            }
            return arrayOfIndexOutput;
        }
    }

    #region Neue Klassen
    public class Vertauscher
    {
        protected Vertauscher() { }// Sperrt den Zugriff auf das Kreiren des Objektes ohne Construktor//
        public Vertauscher(IList<int> permutationTable)
        {
            this.permutationTable = Array.AsReadOnly<int>(permutationTable.ToArray<int>());
        }
        public Vertauscher(string OuputLetters) : this(convertToIntTable(null, OuputLetters)) { }

        public Vertauscher(string inputLetters, string OuputLetters) : this(convertToIntTable(inputLetters, OuputLetters)) { }
        
        public readonly ReadOnlyCollection<int> permutationTable;

        private static int[] convertToIntTable(string inputLetters, string OuputLetters)
        {
            char[] OuputLettersArray = OuputLetters.ToArray();
            char[] Inputletterarray;
            if (inputLetters == null)
            {
                Inputletterarray = OuputLetters.ToArray();
                Array.Sort(Inputletterarray);
            }
            else
                Inputletterarray = inputLetters.ToArray();
            int[] permutationTable = new int[Inputletterarray.Length];
            for (int i = 0; i < Inputletterarray.Length; i++)
            {
                permutationTable[i] = Array.IndexOf<char>(OuputLettersArray, Inputletterarray[i]);
            }

            return permutationTable;
        }
        public virtual int? vertausche(int inputValue)
        {
            if (inputValue < 0)
                return null;
            else if (inputValue >= this.permutationTable.Count)
                return inputValue;
            else
                return permutationTable[inputValue];
        }
    }
    public class HistorsicheReflektoren : Vertauscher
    {
        protected HistorsicheReflektoren(string OuputLetters) : base(OuputLetters) { }

        //Properties
        public static HistorsicheReflektoren UKW_A
        {
            get
            {
                return new HistorsicheReflektoren("EJMZALYXVBWFCRQUONTSPIKHGD");
            }
        }
        public static HistorsicheReflektoren UKW_B
        {
            get
            {
                return new HistorsicheReflektoren("YRUHQSLDPXNGOKMIEBFZCWVJAT");
            }
        }
        public static HistorsicheReflektoren UKW_C
        {
            get
            {
                return new HistorsicheReflektoren("FVPJIAOYEDRZXWGCTKUQSBNMHL");
            }
        }
    }
    public class HistorsicheWalze : Vertauscher
    {
        protected HistorsicheWalze(string OuputLetters) : base(OuputLetters) { }

    }
}

//    internal class HistoricalUKW : Walze
//    {
//        private int[] inputWalze;

//        internal HistoricalUKW(int[] inputWalze)
//        {
//            this.inputWalze = inputWalze;
//        }

//        internal override bool CanBeAppend => false;

//        public override int calculate(Walze input, int inputValue)
//        {
//            return base.calculate(input, inputValue);
//        }
//    }

//    internal class HistoricalWalze : Walze
//    {
//        private int counter;
//        private int[] inputWalze;
//        int movePositionIfHit;

//        internal HistoricalWalze(int[] inputWalze, int movePosition, int startingPosition = 0)
//        {
//            this.inputWalze = inputWalze;
//            counter = startingPosition;
//            movePositionIfHit = movePosition;
//        }

//        internal override bool CanBeAppend => true;

//        public override int calculate(Walze input, int inputValue)
//        {
//            return base.calculate(input, inputValue);
//        }

//        public void Mover()
//        {
//            counter = (counter % inputWalze.Length + inputWalze.Length) % inputWalze.Length;
//            if (counter == movePositionIfHit && NextWalze != null)
//            {
//                NextWalze.Mover();
//                counter++;
//            }
//            else
//            {
//                counter++;
//            }
//        }
//    }
//}
//#endregion
//#region Alte Klassen
//internal abstract class Walze
//    {
//        internal Walze NextWalze;
//        private int[] inputWalze;

//        internal abstract bool CanBeAppend { get; }

//        protected Walze()
//        {
//        }

//        public void AppendWalze(Walze addedWalze)
//        {
//            if (CanBeAppend)
//            {
//                if (NextWalze != null)
//                {
//                    NextWalze.AppendWalze(addedWalze);
//                }
//                else
//                {
//                    NextWalze = addedWalze;
//                }
//            }
//        }

//        public virtual int calculate(int inputValue)
//        {
//            inputValue = input.inputWalze[inputValue];
//            if (inputValue >= 0)
//            {
//                inputValue %= input.inputWalze.Length;
//            }
//            else
//            {
//                inputValue = inputValue % input.inputWalze.Length + input.inputWalze.Length;
//            }
//            if (NextWalze != null)
//            {
//                inputValue = calculate(NextWalze, inputValue);
//            }
//            return inputValue;
//        }
//    }

//    internal class HistoricalUKW : Walze
//    {
//        private int[] inputWalze;

//        internal HistoricalUKW(int[] inputWalze)
//        {
//            this.inputWalze = inputWalze;
//        }

//        internal override bool CanBeAppend => false;

//        public override int calculate(Walze input, int inputValue)
//        {
//            return base.calculate(input, inputValue);
//        }
//    }

//    internal class HistoricalWalze : Walze
//    {
//        private int counter;
//        private int[] inputWalze;
//        int movePositionIfHit;

//        internal HistoricalWalze(int[] inputWalze, int movePosition, int startingPosition = 0)
//        {
//            this.inputWalze = inputWalze;
//            counter = startingPosition;
//            movePositionIfHit = movePosition;
//        }

//        internal override bool CanBeAppend => true;

//        public override int calculate(Walze input, int inputValue)
//        {
//            return base.calculate(input, inputValue);
//        }

//        public void Mover()
//        {
//            counter = (counter % inputWalze.Length + inputWalze.Length) % inputWalze.Length;
//            if (counter == movePositionIfHit && NextWalze != null)
//            {
//                NextWalze.Mover();
//                counter++;
//            }
//            else
//            {
//                counter++;
//            }
//        }
//    }
//}
#endregion