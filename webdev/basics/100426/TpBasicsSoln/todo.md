# add ProductsPage
- 1.  add ProductsController [cls]
- 2a. add Index() [Action-Method]
- 2b. add Index.cshtml [View]
- 3a. add Details() [Action-Method]
- 3b. returns Content int?

# add Model
- 1. [Model/Categories.cs] add Cats class in Model folder
- 2. [Model/Categories.cs] add properties: id, name, desc
- 3. [View/Edit.cshtml] add Cats.Edit.View: 
- 4. [View/Edit.cshtml] add ref to @Models class to View[Edit.cshtml]
- 5. [View/Edit.cshtml] add ref to @Models instance & Display Property: eg Id, Name etc
- 6. [Controller/Cat.Edit()] create Model.Cats instance with input id
- 7. [Controller/Cat.Edit()] add instance to View(category)


# add layout
- 1. add Shared/_Layout.cshtml