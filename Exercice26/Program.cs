

namespace Exercice26
{
  public class Program
  {
    public const int QUIT = 0;
    public const int LIST_ALL_BOOKS = 1;
    public const int LIST_AVAILABLE_BOOKS = 2;
    public const int LIST_BORROWED_BOOKS = 3;

    public static void Main ( string[] args )
    {
      // ppoulin
      // 1.3 b) Déclarez ici une bibliothèque

      // ppoulin
      // 1.3 c) Initialisez la bibliothèque en faisant l'appel à la fonction codée en 1.3

      // ppoulin
      // 1.4 b) Faites l'appel de la fonction AddSomeBooks ici


      int userOption;
      // Menu
      do
      {
        PrintMenu ();
        userOption = ReadInteger ("Entrez votre choix: ", QUIT, LIST_BORROWED_BOOKS);
        if (userOption == LIST_ALL_BOOKS)
        {
          // ppoulin
          // 1.5 a) Écrivez le code pour lister tous les livres (disponibles et empruntés)
        }
        else if (userOption == LIST_AVAILABLE_BOOKS)
        {
          // ppoulin
          // 1.5 b) Écrivez le code pour lister uniquement les livres disponibles
        }
        else if (userOption == LIST_BORROWED_BOOKS)
        {
          // ppoulin
          // 1.5 c) Écrivez le code pour lister uniquement les livres empruntés
        }
      } while (userOption != QUIT);
    }

    // ppoulin
    // 1.3 a) Complétez ici la fonction permettant d'initialiser une bibliothèque
    private static void InitLibrary ( /* A compléter en passant la bibliothèque en paramètre*/ )
    {
      // A COMPLETER
    }
    // ppoulin
    // 1.4 a) Complétez la fonction afin d'ajouter quelques livres disponibles et quelques livres empruntés dans
    //        la bibliothèque. Vous êtes encouragés (ées) à utiliser les valeurs suggérées pour sauver du temps.
    private static void AddSomeBooks ( /* Ajoutez la bibliothèque en paramètre*/ )
    {
      string[] authors = { "Stephen King", "J.K. Rowling", "J.K. Rowling", "George R.R. Martin" };
      string[] titles = { "Carrie", "Harry Potter and the Philosopher's Stone", "Harry Potter and the Chamber of Secrets", "A Game of Thrones" };
      string[] editionCompany = { "Gallimard", "Bloomsbury", "Bloomsbury", "Bantam Spectra " };
      int[] numberOfPages = { 226, 223, 251, 694 };
      string[] isbns = { "978-0-385-08695-0", "978-0-7475-3269-9", "0-7475-3849-2", "0-553-10354-7" };

      // A compléter:
      // Vous devez
      // 1) créer un livre
      // 2) l'initialiser correctement avec les valeurs
      // 3) l'ajouter à la bibliothèque (soit dans les livres disponibles ou dans les livres empruntés)
      // La bibliothèque devra être reçue en paramètre

    }




    public static void PrintMenu ()
    {
      Console.Clear ();
      Console.WriteLine ("Options disponibles");
      Console.WriteLine ("===================");
      Console.WriteLine ($"{QUIT} Quitter");
      Console.WriteLine ($"{LIST_ALL_BOOKS} Afficher tous les livres");
      Console.WriteLine ($"{LIST_AVAILABLE_BOOKS} Afficher les livres disponibles");
      Console.WriteLine ($"{LIST_BORROWED_BOOKS} Afficher les livres empruntés");
      Console.WriteLine ("");
    }

    public static int ReadInteger ( string message, int minValue, int maxValue )
    {
      int value = 0;
      do
      {
        Console.Write (message);
        value = int.Parse (Console.ReadLine ());
      }
      while (value < minValue || value > maxValue);

      return value;
    }
  }
}