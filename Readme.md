<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582891/18.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T292798)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to edit the SqlDataSource connection and query at runtime via wizard by using the SqlDataSourceUIHelper class


<p>This example demonstrates how to use the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressDataAccessUISqlSqlDataSourceUIHelpertopic">SqlDataSourceUIHelper</a> class to give the End-User a capability to edit the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessSqlSqlDataSourcetopic">SqlDataSource</a> component's connection or queries at runtime via wizards.</p>
<p>To execute a connection configuration wizard, call the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressDataAccessUISqlSqlDataSourceUIHelper_ConfigureConnectiontopic">SqlDataSourceUIHelper.ConfigureConnection</a> method and pass the SqlDataSource component instance to it. <br />To execute a query editing wizard, call the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressDataAccessUISqlSqlDataSourceUIHelper_EditQuerytopic">SqlDataSourceUIHelper.EditQuery</a> method and pass the SqlDataSource component's SqlQuery instance to it. <br /><strong>Note</strong> that it is necessary to refill the SqlDataSource after its connection or query was edited. Use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessSqlSqlDataSource_Filltopic">SqlDataSource.Fill</a> method for this purpose.<br /><br />Finally, I would like to mention that the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressDataAccessUISqlSqlDataSourceUIHelpertopic">SqlDataSourceUIHelper</a> class also provides other wizards that can be used to configure the SqlDataSource component. Please refer to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressDataAccessUISqlSqlDataSourceUIHelperMembersTopicAll">SqlDataSourceUIHelper Members</a> help topic for more information regarding this.</p>
<br /><br /><strong>See also:<br /></strong><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument18167">Binding to SQL Data</a><br /><a href="https://www.devexpress.com/Support/Center/p/T291969">T291969: SqlDataSource - How to change connection parameters at runtime</a>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-edit-the-sqldatasource-connection-and-query-at-runtime&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-edit-the-sqldatasource-connection-and-query-at-runtime&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
