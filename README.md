# Junction-creator
Creates junctions/symlinks to all directory/file from an input directory to an output directory

Let's say you have lot of movies on multiple drives, and you want to have them in one single directory.
In my simple test case, i have movies in these two distinct directory:

C:\Users\zotya>dir "E:\MOVIES"
 Volume in drive E is WD 1TB
 Volume Serial Number is 7EAD-81D0

 Directory of E:\MOVIES

2017-04-30  06:25    <DIR>          .
2017-04-30  06:25    <DIR>          ..
2017-04-30  06:24    <DIR>          12 Angry Men
2017-04-30  06:25                 0 Schindler's List.mkv
2017-04-30  06:24    <DIR>          The Dark Knight
2017-04-30  06:23    <DIR>          The Godfather
2017-04-30  06:23    <DIR>          The Godfather Part II
2017-04-30  06:21    <DIR>          The Shawshank Redemption
               1 File(s)              0 bytes
               7 Dir(s)  111,084,064,768 bytes free
               
C:\Users\zotya>dir "F:\MOVIES"
 Volume in drive F is WD 3TB
 Volume Serial Number is 7EF1-D3D5

 Directory of F:\MOVIES

2017-04-30  06:27    <DIR>          .
2017-04-30  06:27    <DIR>          ..
2017-04-30  06:26    <DIR>          Fight Club
2017-04-30  06:26    <DIR>          Il buono, il brutto, il cattivo
2017-04-30  06:25    <DIR>          Pulp Fiction
2017-04-30  06:27                 0 Star Wars Episode V - The Empire Strikes Back.mkv
2017-04-30  06:26    <DIR>          The Lord of the Rings The Fellowship of the Ring
2017-04-30  06:26    <DIR>          The Lord of the Rings The Return of the King
               1 File(s)              0 bytes
               7 Dir(s)  2,092,018,057,216 bytes free
               
After running the program, i have acces to the contents of E:\MOVIES in F:MOVIES:

C:\Users\zotya>dir "F:\MOVIES"
 Volume in drive F is WD 3TB
 Volume Serial Number is 7EF1-D3D5

 Directory of F:\MOVIES

2017-04-30  06:44    <DIR>          .
2017-04-30  06:44    <DIR>          ..
2017-04-30  06:44    <JUNCTION>     12 Angry Men [E:\MOVIES\12 Angry Men]
2017-04-30  06:26    <DIR>          Fight Club
2017-04-30  06:26    <DIR>          Il buono, il brutto, il cattivo
2017-04-30  06:25    <DIR>          Pulp Fiction
2017-04-30  06:44    <SYMLINK>      Schindler's List.mkv [E:\MOVIES\Schindler's List.mkv]
2017-04-30  06:27                 0 Star Wars Episode V - The Empire Strikes Back.mkv
2017-04-30  06:44    <JUNCTION>     The Dark Knight [E:\MOVIES\The Dark Knight]
2017-04-30  06:44    <JUNCTION>     The Godfather [E:\MOVIES\The Godfather]
2017-04-30  06:44    <JUNCTION>     The Godfather Part II [E:\MOVIES\The Godfather Part II]
2017-04-30  06:26    <DIR>          The Lord of the Rings The Fellowship of the Ring
2017-04-30  06:26    <DIR>          The Lord of the Rings The Return of the King
2017-04-30  06:44    <JUNCTION>     The Shawshank Redemption [E:\MOVIES\The Shawshank Redemption]
               2 File(s)              0 bytes
              12 Dir(s)  2,092,018,057,216 bytes free
              
One can create junctions and symlinks on windows in cmd with mklink command, but that's pretty a pain in the ass for
multiple directories and files, so i created this little c# program to automate this procedure.
