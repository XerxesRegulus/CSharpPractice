using CookieCookbook;
using CookieCookbook.Enums;

const FileFormat format = FileFormat.Json;
// Read file if has ingredients print em
RecipePrinter recipePrinter = new RecipePrinter(format);
recipePrinter.Print();

Console.WriteLine("");

// Ask user for ingredients
RecipeBuilder recipeBuilder = new RecipeBuilder(format);
recipeBuilder.Build();