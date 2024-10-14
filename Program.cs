int a=10, b=20;
BytPlats(ref a, ref b);
Console.WriteLine(a+" "+b);

	
static void BytPlats(ref int a1, ref int b1){
    int test = a1;
    a1 = b1;
    b1 = test;
}


Console.WriteLine("10 upphöjt till 7: "+Power(10,7));
Console.WriteLine("2 upphöjt till 10: "+Power(2,10));

static double Power(double a, double b){
   double test = a;
    for(int aa = 1; aa < b; aa++){
        test = test * a;
    }

    return test;
}
