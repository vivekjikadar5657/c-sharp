class DemoofLiterals
{
	public static void main(String[] args)
	{
		//Integer Literals
		int decimalLiterals = 100; //Decimal 
		int binaryLiterals = 0b1100100; //Binary Prefix (0,b) 
		int octalLiterals = 0144; //Octal (Prefix 0)
		int hexLiterals = 0x64; //HexaDecimal (Prefix 0,a) 
		
		//floating Literals	
		float floatLiteral = 2.718f; //float literal
		
		//Character Literals
		char CharLiteral = 'A';
		
		//String Literals
		String StringLiteral = "Hello world";
		
		//Boolean Literals
		Boolean trueLiteral = true;
		Boolean falseLiteral = false;
		
		//Null Literal (for objects)
		String nullLiteral = null;
		
		System.out.println("Literlas................................");
		
		System.out.println("DecimalLiterals = "+decimalLiterals);
		System.out.println("BinaryLiterals = " +binaryLiterals);
		System.out.println("OctalLiterals = " +octalLiterals);
		System.out.println("HexadecimalLiterals = " + hexLiterals);
		
		System.out.println("floatLiteral = " + floatLiteral); // float
		
		System.out.println("charLiteral = " + CharLiteral); // char
		System.out.println("stringLiteral = " + StringLiteral);
		
		System.out.println("Boolean True Literal = " + trueLiteral);
		System.out.println("Boolean False Literal = " + falseLiteral);
		
		System.out.println("NullLiteral = " + nullLiteral);
	}
}