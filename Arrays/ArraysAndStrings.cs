namespace Arrays
{
    internal class ArraysAndStrings
    {
        public int CountCharInString(string inputString, char inputChar)
        {
            int result = 0;

            //TODO: Escriba aquí el algoritmo para contar
            // las ocurrencias de inputChar en inputString

            return result;
        }

        public int NextPowerOfTwo(int currentNumber)
        {
            int result = 0;
            int string PowerOfTwo {1,4,9,16,25,36,49,64,81,100,144}
            for (currentNumber = x, PowerOfTwo = 0)
                if (x < & = PowerOfTwo)
                {
                    int result = PowerOfTwo;
                }
            else if (x > & = PowerOfTwo)
                {
                    PowerOfTwo += 1;
                    return PowerOfTwo;
                }
            return result;
        }

        public int FibonacciAtN(int fibonacciPositioon)
        {
            int result = 0;
            fibonacciLenght = n;
            fibonacci1 = 0;
            fibonacci2 = 1;
            for (
                fibonacciPositioon = 0:
                fibonacciPositioon2 = 1;
                )
                if (fibonacciPositioon2 < fibonacciLenght)
                {
                    fibonacci1 + fibonacci2 = fibonacci3;
                    fibonacciPositioon += 1;
                    fibonacciPösitioon2 += 1;
                    result = fibonacci3;
                }
            else if (fibonacciPositioon2 = fibonacciLenght)
                {
                    FibonacciAtN = result;
                }
            }    
            return result;
        }

        public int MultiplesOfThreeInArray(int[] inputArr)
        {
            int result = 0;
            numero = n;
        if (n/3 == int number)
            {
            result = 1;
        }
        else if(n/3 != int number)
            {
            result = 0;
            }
            return result;
        }

        public bool NumberIsMultipleOf(int inputNum, int inputFactor)
        {
            bool result = false;
        inputNum = n;
        inputFactor = x;
        if (inputNum/inputFactor == int number)
                    {
                    result = true;
                }
            }
            else
                    if (inputNum/inputFactor != int number)
                    {
                    result = false;
                }
            return result;
        }

        public bool MatrixIsIdentity(int[,] inputMatrix)
        { bool fila = 0;
          bool columna = 0;
            bool result = true;
            for [fila == columna]
                if ( [fila == columna] != 1)
                { result = false;
                    break;
                }
                else
                    if ([fila != columna] != 0)
                {
                    result = false;
                    break;
                }
                        
            return result;
        }

        public bool ElementsInDiagonalAreEqual(int[,] inputMatrix)
        {
            bool result = false;
    string columna = 0;
       string fila = 0;
    columnaLenght = x;
    filaLenght = y;
    if (fila < filaLenght)
    {
        if (columna == fila)
        {
            result = false;
        }
        else if (columna != fila)
        {
            result = false;
        }
    }
    return result;
        }

        public int OperateElementsInArray(int[] inputArr)
        {
            int result = 0;
    numero = 0;
    ArrLengh = x;
    position1 = 0;
    position2 = 1;

    if (position2 < ArrLenght)
    {
        position1 + position2 = numero;
        position1 += 1;
    }
    else if(position2 > ArrLenght)
    {
        result = numero;
        break;
    }
            return result;
        }

        public int CountVowelsInString(string inputString)
        {
            int result = 0;
    string vocalString {a, A, e, E, i, I, o, O, u, U};
    int numero = 0;
    vocalPosition = 0;
    vocalLenght = 10;
    StringPosition = 0;
    StringLenght = x;
    if(StringPosition < StringLenght)
    {
        if (stringPosition == vocalPosition)
        {
            numero += 1;
            stringPosition += 1;
            vocalPosition = 0;
        }
        else
            if (stringhPosition != vocalPosition)
        {
            vocalPosition += 1;
            return vocalPosition;
        }
    }
    else
    if(stringPosition = StringLenght)
    {
        break;
        result = numero;
    }
            return result;
        }

        public int CountConsonantInString(string inputString)
        {
            int result = 0;
    string ConsonantString {b, B, c, C, d, D, f, F, g, G, h, H, j, J, k, K, l, L, m, M, n, N, ñ, Ñ p, P, q, Q, r, R, s, S, t, T, v, V, w, W, x, X, y, Y, z, Z };
    stringposition = 0;
    stringLenght = x;
    ConsonantPosition = 0;
    ConsonantLenght = 44;
    if (StringPosition < StringLenght)
    {
        if (stringPosition == ConsonantPosition)
        {
            numero += 1;
            stringPosition += 1;
            ConsonantPosition = 0;
        }
        else
            if (stringhPosition != ConsonantPosition)
        {
            ConsonantPosition += 1;
            return vocalPosition;
        }
    }
    else
    if (stringPosition = StringLenght)
    {
        break;
        result = numero;
    }
    return result;
        }

public string StringHasOddOrEvenCharCount(string inputString)
{
    string result = string.Empty;
    bool result = Par
        stringPosition = 0
        stringLenght = string inputString;
    palabra = 0;
    if (stringPosition < stringLenght)

    {
        palabra = 0;
        palabra += 1;
        return palabra;
    }
    else if (stringPosition = stringLenght)
    {
        break;
        if (palabra / 2 == int number)
            {
            result = Par;
        }
        else if (palabra / 2 != int number)
            {
            result = Impar;
        }

        //TODO: Para indicar que el conteo es par, retornar "PAR"
        //Para indicar que el conteo es inpar, retornar "IMPAR"

        return result;
    }
}

public string ProductOfElementsIsOddOrEven(int[] inputArr)
{
    string result = string.Empty;
}

        public string RacerGotFirst(float d1, float t1, float d2, float t2)
        {
            string result = string.Empty;
    bool d1 = x;
    bool t1 = tx;
    bool d2 = x2;
    bool t2 = tx2;
    if (d1 / t1 > d2 / t2)
    {
        result = Primero;
    }
    else
        if (d1 / t1 < d2 / t2)
    {
        result = Segundo;
    }
    return result;
        }
    }
}