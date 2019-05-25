#include<iostream>

 using namespace std;

int main()
{
	int Valor, N100, R100, N50, R50, N20, R20, N10, R10, N5, R5, N2, R2, N1;
	
	cin >> Valor;
	
	N100 = Valor / 100; 
	R100 = Valor % 100;
	
	N50 = R100 / 50; 
	R50 = R100 % 50; 
	
	N20 = R50 / 20; 
	R20 = R50 % 20; 
	
	N10 = R20 / 10; 
	R10 = R20 % 10; 
	
	N5 = R10 / 5; 
	R5 = R10 % 5; 
	
	N2 = R5 / 2; 
	R2 = R5 % 2; 
	
	N1 = R2 / 1; 
	
	cout << Valor <<endl 
	 << N100 <<" nota(s) de R$ 100,00" <<endl
	 << N50 <<" nota(s) de R$ 50,00" <<endl
	 << N20 <<" nota(s) de R$ 20,00"  <<endl
	<< N10 << " nota(s) de R$ 10,00"<<endl
	 << N5 << " nota(s) de R$ 5,00"<<endl
	 <<  N2 << " nota(s) de R$ 2,00"<<endl
	<< N1 << " nota(s) de R$ 1,00" <<endl;
}
