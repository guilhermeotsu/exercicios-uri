#include<iostream>
#include<iomanip>
#include<stdio.h>

using namespace std;

int main(){
	int a, b;
	float c, d;
	
	a = 15;
	b = 15 / 2;
	c = 15.456;
	d = (float)c / 7.0;
	
	cout << "Valores de b:" << endl
		 << "-------------" << endl
		 << "1) b = " << b <<endl
		 << "2) b =                    " << b << endl
		 << "3) b = 0000000000000000000" << b << endl;
	printf("4) b = %i                   \n",b);
	cout << "5) b = " << b <<"%" << endl
		 << endl
		 << "Valores de d:" << endl
		 << "-------------" << endl;
		 printf("1) d = %.6f\n",d);
	cout << "2) d = " << (int) d << endl;
	 printf("3) d = %.1f\n",d);
   	printf("4) d = %.2f\n",d);
       	cout << "5) d = " << d << fixed << setprecision(3) << endl	 
		 << "6) d =                " << d << fixed << setprecision(3) << endl
		 << "7) d = 000000000000000" << d << fixed << setprecision(3) << endl
		 << "8) d = " << d << fixed << setprecision(3) << "               " << endl;
		 printf("9) d = %.2f%\n",d);
	
	
	return 0;
}
