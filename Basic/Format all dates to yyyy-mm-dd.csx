/*
 * Title: Format all date/datetime to 'yyyy-mm-dd'
 * 
 * Author: Eric Heflin, linkedin.com/in/ejheflin
 * 
 * This script, when executed, will loop through all the columns in the model,
 * any datatypes containing the word 'Date' (includes date and datetime at the
 * time of this writing) will be formatted to 'yyyy-mm-dd'.
 */

foreach ( var m in Model.AllColumns.Where(m => m.DataType.ToString().Contains("Date")) ) {
    m.FormatString = "yyyy-mm-dd";
}