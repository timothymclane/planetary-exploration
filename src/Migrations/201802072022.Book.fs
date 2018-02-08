namespace Migrations
open SimpleMigrations

[<Migration(201802072022L, "Create Books")>]
type CreateBooks() =
  inherit Migration()

  override __.Up() =
    base.Execute(@"CREATE TABLE Books(
      id string NOT NULL,
      title string NOT NULL,
      author string NOT NULL
    )")

  override __.Down() =
    base.Execute(@"DROP TABLE Books")
