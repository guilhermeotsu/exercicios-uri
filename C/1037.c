#include<stdio.h>

int main() 
{
	float N; 
	
	scanf("%f", &N);
	
	if ((N < 0.0) || (N > 100.0))
		printf("Fora de intervalo\n");
		else
			if ((N >= 0.0) && (N <= 25.0)) 
				printf("Intervalo [0,25]\n");
				else
	     			 if ((N > 25.0) && (N <= 50.0))
						printf("Intervalo (25,50]\n");
	    				else
          					if ((N > 50.0) && (N <= 75.0))
								printf("Intervalo (50,75]\n");
								else
									if ((N > 75.0) && (N <= 100.0))
										printf("Intervalo (75,100]\n");
							
	
	return 0;
}
