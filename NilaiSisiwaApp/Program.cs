int nilai;
string nama;

Console.WriteLine("Aplikasi nilai si*swa");

Console.WriteLine("Nama siswa: ");
nama = Console.ReadLine();

Console.WriteLine("Nilai; ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("Selamat, lulus le");
}
else
{
    Console.WriteLine("selamat anda tinggal kelas");
}