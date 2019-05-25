#include <stdio.h>
#include <math.h>

int main()
{
    double A, B, C, ATri, ACir, ATra, AQua, ARet;

    scanf("%lf %lf %lf", &A, &B, &C);

    ATri = ((A * C) / 2);
    ACir = 3.14159 * (C * C);
    ATra = (((B + A) * C) / 2);
    AQua = B * B;
    ARet = A * B;

    printf("TRIANGULO: %.3lf\nCIRCULO: %.3lf\nTRAPEZIO: %.3lf\nQUADRADO: %.3lf\nRETANGULO: %.3lf\n",ATri, ACir, ATra, AQua, ARet);

    return 0;
}
