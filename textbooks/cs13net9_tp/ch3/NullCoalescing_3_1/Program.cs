// 1.  create fictional function and assign to a str [authName]

string? authName = getAuthName();

// 2.  apply null coalescing logic:
// 2a. - [MaxLength] variable is length of authorName if not [null],
// 2b. - 30 if [authorName] is [null].

int MaxAuthNameLength = authName?.Length ?? 30;
// 3. [authorName] will be "unknown" if authorName was [null].

authName ??= "Unknown";
WriteLine("{0}, {1}",authName, MaxAuthNameLength);

//string getAuthName() { return "old mate"; }
