using System;

namespace Exercise07_Catalog
{
    /// <summary>
    /// Create the classes diagram and then, using Visual Studio, 
    /// a project and the corresponding classes for a catalog utility:
    /// 
    /// It will be able to store information about music files, films and computer programs.
    /// For each item, it must store: name, code, category and size.For films it must also hold the director, 
    /// the main actor and the main actress.For music files, the singer and the length (in seconds).
    /// For music and movies it must have a method "Play" (not implemented yet) and also a method "RetrieveInformation", 
    /// which will(in a later version) connect to an internet server to get information about it.
    /// Use inheritance if needed.In "Main", create arrays of each kind of object.
    /// </summary>
    internal class TestItem
    {
        static void Main(string[] args)
        {
            Film[] myFilms = new Film[3];
            Music[] myMusic = new Music[3];
            ComputerProgram[] myComputerProgram = new ComputerProgram[3];
        }
    }
}
