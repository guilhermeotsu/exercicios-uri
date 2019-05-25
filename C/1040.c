#include<stdio.h>

int main(){ 

	float n1, n2, n3, n4, media, nexame, mediaexame; 
	
	scanf("%f %f %f %f", &n1, &n2, &n3, &n4);
	
	media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10.0;
	
	if ((media >= 5.0) && (media <= 6.9))
	{
		scanf("%f", &nexame); 		    
		printf("Media: %.1f\n", media);
		printf("Aluno em exame.\n"); 
		printf("Nota do exame: %.1f\n", nexame);
		mediaexame = (media + nexame) / 2.0; 
		if (mediaexame >= 5.0) 
			printf("Aluno aprovado.\n");
				
		if (mediaexame < 5.0)
			printf("Aluno reprovado.\n");
			
		printf("Media final: %.1f\n", mediaexame);			
	}
				
		if (media >= 7.0) {		
		printf("Media: %.1f\n", media);
		printf("Aluno aprovado.\n");	
		}
		
		if (media < 5.0){		
		printf("Media: %.1f\n", media);
		printf("Aluno reprovado.\n");
		}
		
		return 0; 
			
}
