#include<iostream>
#include<stdio.h>

using namespace std;

int main (){
	double s =1; 
	int x = 2;
	
	for(int i = 3; i <= 39; i++){
		s += (double)i/x;
		i++;
		x *=2;
	}
	printf("%.2lf\n", s);
	return 0;
}
