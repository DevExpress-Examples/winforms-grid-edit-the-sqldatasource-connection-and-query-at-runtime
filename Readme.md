<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582891/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T292798)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms Grid - How to Edit the SQL Data Source Connection and Query at Runtime

This example demonstrates how to use the [SqlDataSourceUIHelper](https://docs.devexpress.com/WindowsForms/DevExpress.DataAccess.UI.Sql.SqlDataSourceUIHelper) class to give the End-User a capability to edit the [SqlDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.SqlDataSource) component's connection or queries at runtime via wizards.

## Implementation Details

To execute a connection configuration wizard, call the [SqlDataSourceUIHelper.ConfigureConnection](https://docs.devexpress.com/WindowsForms/devexpress.dataaccess.ui.sql.sqldatasourceuihelper.configureconnection.overloads) method and pass the `SqlDataSource` component instance to it.

To execute a query editing wizard, call the [SqlDataSourceUIHelper.EditQuery](https://docs.devexpress.com/WindowsForms/devexpress.dataaccess.ui.sql.sqldatasourceuihelper.editquery.overloads) method and pass the `SqlDataSource` component's `SqlQuery` instance to it.

> [!Note]
> Refill the `SqlDataSource` after its connection or query is edited. Use the [SqlDataSource.Fill](https://docs.devexpress.com/CoreLibraries/devexpress.dataaccess.sql.sqldatasource.fill.overloads) method for this purpose.

The [SqlDataSourceUIHelper](https://docs.devexpress.com/WindowsForms/DevExpress.DataAccess.UI.Sql.SqlDataSourceUIHelper) class also provides other wizards that can be used to configure the SqlDataSource component. Please refer to the [SqlDataSourceUIHelper Members](https://docs.devexpress.com/WindowsForms/DevExpress.DataAccess.UI.Sql.SqlDataSourceUIHelper._members) help topic for more information.

## Files to Review
* [Form1.cs](./CS/T292798/Form1.cs) (VB: [Form1.vb](./VB/T292798/Form1.vb))

## Documentation

* [Binding to SQL Data](https://docs.devexpress.com/WindowsForms/18167/common-features/data-binding/binding-to-sql-data)
* [Specify Data Connection](https://docs.devexpress.com/CoreLibraries/403634/devexpress-data-library/data-sources/use-the-sql-data-source/specify-data-connection)
<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-edit-the-sqldatasource-connection-and-query-at-runtime&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-edit-the-sqldatasource-connection-and-query-at-runtime&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
