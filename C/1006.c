#include <stdio.h> 

int main() 
{
	double N1, N2, N3, Media; 
	
	scanf("%lf%lf%lf", &N1, &N2, &N3); 
	
	Media = ((N1 * 2) + (N2 * 3) + (N3 * 5)) / 10; 
	
	printf("MEDIA = %.1lf\n", Media);
	
	return 0;	
}