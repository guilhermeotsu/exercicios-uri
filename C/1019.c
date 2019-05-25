#include<stdio.h>

int main()
{ 
	int N, H, M, S; 
	
	scanf("%i", &N); 
	
	H = N / 3600; 
	M = N % 3600 / 60; 
	S = N % 60; 
	
	printf("%i:%i:%i\n", H, M, S);
	
	return 0;	
}
