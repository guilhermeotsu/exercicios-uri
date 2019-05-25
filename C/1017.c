#include <stdio.h>

int main()
{
	int T, V; 
	float QntLit; 
	
	scanf("%i%i", &T, &V); 
	
	QntLit = (T * V) / 12.0; 
		
	printf("%.3f\n", QntLit);
	
  return 0;
}
