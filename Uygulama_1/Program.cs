// 5! = 5 * 4 * 3 * 2 * 1 =  120 
// 6! = 6 * 5 * 4 * 3 * 2 * 1  = 720
// 6! = 6 * 5!

Console.WriteLine(Faktoriyel(5));


int Faktoriyel(int n)
{
    int carpim = 1;

    for (int i = 1; i<=n;i++)
    {
        carpim*= i;
    }
    return carpim;
}


int Permutasyon(int n, int r)
{
    return Faktoriyel(n) / (Faktoriyel(n-r));
}


//  C(n,r) = P(n,r) / r!


int Kombinasyon(int n, int r)
{
    return Permutasyon(n, r) / Faktoriyel(r);
}

// P(5,2) = 5 * 4 
// P(5,3) = 5 * 4 * 3
// C(5,3) = 5 * 4 * 3
//         ----------
//          3 * 2 * 1
Console.WriteLine(Permutasyon(5,2));
Console.WriteLine(Permutasyon(5, 3));
Console.WriteLine(Kombinasyon(5,3));