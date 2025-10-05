
// 1.  get [authorName] str
string? authorName = GetAuthorName(false);

// 2.  null-coalesc logic
// 2a. return [authorName.Length]   if not  [null]
// 2b. return [30]                  if      [null]
int authorNameLength = authorName?.Length ?? 69;

// 3. authorName "unknown"          if      [null]
authorName ??= "mystery man";

// 4. print
Console.WriteLine("{0}, {1}", authorName, authorNameLength);
string? GetAuthorName(bool isAuth = true)
{
	if (isAuth)
	{
		return "old buddy";
	}
	return null;
}