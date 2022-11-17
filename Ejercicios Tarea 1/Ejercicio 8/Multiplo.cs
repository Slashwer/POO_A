class Multiplo{
    public int NUM{get;set;}
    public Multiplo(int NUM){
        this.NUM=NUM;
    }
    public void MultiploDeNumero(){
        Console.WriteLine("Multiplos de numero "+NUM+" hasta el 3ooo;");
        for(int cont=NUM;cont<=3000;cont=cont+NUM){
            Console.WriteLine(cont);
        }
    }
}