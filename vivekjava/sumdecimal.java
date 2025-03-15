class sumdecimal
{
	public static void main(String[] args)
	{
		//Integer Literals
		int decimalLiterals = 100; //Decimal 
		int decimalLiteral=101;
		
		int binaryLiterals =0b1100100; //Binary Prefix (0,b) 
		int binaryLiteral=0b1100100;
		
		int octalLiterals = 0144; //Octal (Prefix 0)
		int octalLiteral=0022;
		
		int hexLiterals = 0x64; //HexaDecimal (Prefix 0,a)
		int hexLiteral=0x32;
		
		System.out.println("Decimal..................");
		System.out.println("DecimalLiterals sum = "+(decimalLiterals+decimalLiteral));
		System.out.println("DecimalLiterals sub= "+(decimalLiterals-decimalLiteral));
		System.out.println("DecimalLiterals div= "+(decimalLiterals/decimalLiteral));
		System.out.println("DecimalLiterals mul= "+(decimalLiterals*decimalLiteral));
		System.out.println("\n");

		System.out.println("Binary..................");
		System.out.println("BinaryLiterals sum= "+(binaryLiterals+binaryLiteral));
		System.out.println("BinaryLiterals sub= "+(binaryLiterals-binaryLiteral));
		System.out.println("BinaryLiterals div= "+(binaryLiterals/binaryLiteral));
		System.out.println("BinaryLiterals mul= "+(binaryLiterals*binaryLiteral));
		System.out.println("\n");

		System.out.println("Octal..................");
		System.out.println("OctalLiterals sum= "+(octalLiterals+octalLiteral));
		System.out.println("OctalLiterals sub= "+(octalLiterals-octalLiteral));
		System.out.println("OctalLiterals div= "+(octalLiterals/octalLiteral));
		System.out.println("OctalLiterals div= "+(octalLiterals*octalLiteral));
		System.out.println("\n");

		

		System.out.println("hex..................");
		System.out.println("HexadecimalLiterals sum= "+(hexLiterals+hexLiteral));
		System.out.println("HexadecimalLiterals sub= "+(hexLiterals-hexLiteral));
		System.out.println("HexadecimalLiterals div= "+(hexLiterals/hexLiteral));
		System.out.println("HexadecimalLiterals mul= "+(hexLiterals*hexLiteral));
		System.out.println("\n");

	}
}