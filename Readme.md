<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626351/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T190498)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

#  WinForms Data Grid - Configure the SQL Data Source and bind it to the grid

This example demonstrates how to:

* Create and configure the SqlDataSource component
  
  ```csharp
  private static SqlDataSource InitData() {
      MsSqlConnectionParameters connectionParameters = new MsSqlConnectionParameters("localhost", "nwind.mdf", "username", "password", MsSqlAuthorizationType.SqlServer);
      SqlDataSource ds = new SqlDataSource(connectionParameters);
      CustomSqlQuery query = new CustomSqlQuery();
      query.Name = "customQuery1";
      query.Sql = "SELECT * FROM Products";
      ds.Queries.Add(query);
      ds.Fill();
      return ds;
  }
  ```
* Bind the `GridControl` to a Microsoft SQL Server database.

```csharp
  private void Init() {
      SqlDataSource ds = InitData();
      Grid.DataSource = ds;
      Grid.DataMember = "customQuery1";
  }
```


## Files to Review

* [Form1.cs](./CS/dxSample/Form1.cs) (VB: [Form1.vb](./VB/dxSample/Form1.vb))


## Documentation

* [Binding to SQL Data](https://docs.devexpress.com/WindowsForms/18167/common-features/data-binding/binding-to-sql-data)
* [Data Binding - WinForms Data Grid](https://docs.devexpress.com/WindowsForms/634/controls-and-libraries/data-grid/data-binding)


## See Also

* [How to use the SqlDataSource component to provide data for the GridControl at design time](https://supportcenter.devexpress.com/ticket/details/t190494/how-to-use-the-sqldatasource-component-to-provide-data-for-the-gridcontrol-at-design-time)
* [Data Binding - DevExpress WinForms Troubleshooting﻿](https://supportcenter.devexpress.com/ticket/details/t925839/devexpress-winforms-troubleshooting-data-binding)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-create-configure-sql-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-create-configure-sql-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
