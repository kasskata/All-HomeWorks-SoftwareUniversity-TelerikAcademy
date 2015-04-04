<form method="get">
    <label for="categories">Categories:</label>
    <input type="text" name="categories"/>
    <br>
    <label for="tags">Tags:</label>
    <input type="text" name="tags"/>
    <br>
    <label for="months">Months:</label>
    <input type="text" name="months"/>
    <br>
    <input type="submit" value="Generate"/>
</form>
<?php
/**
 * Write a PHP program SidebarBuilder.php that takes data from
 * several input fields and builds 3 sidebars. The input
 * fields are categories, tags and months. The first
 * sidebar should contain a list of the categories, the
 * second sidebar – a list of the tags and the third should
 * contain the months. The entries in the input strings
 * will be separated by a comma and space ", ". Styling
 * the page is optional. Semantic HTML is required.
 */
if (isset($_GET['categories']) && isset($_GET['tags']) && isset($_GET['months'])
) {
    $months = explode(", ",$_GET['months']);
    $tags = explode(", ",$_GET['tags']);
    $categories = explode(", ",$_GET['categories']);
    echo("<ul style='list-style-type:circle; border: 1px solid black; border-radius: 5px; background:linear-gradient(cornflowerblue,dodgerblue); width:200px; '>".'Categories');
    echo("<hr style='margin-left: 3px; width:97%;'/>");
    printUL($categories);
    echo("<ul style='list-style-type:circle; border: 1px solid black; border-radius: 5px; background:linear-gradient(cornflowerblue,dodgerblue); width:200px; '>".'Tags');
    echo("<hr style='margin-left: 3px; width:97%;'/>");
    printUL($tags);
    echo("<ul style='list-style-type:circle; border: 1px solid black; border-radius: 5px; background:linear-gradient(cornflowerblue,dodgerblue); width:200px; '>".'Months');
    echo("<hr style='margin-left: 3px; width:97%;'/>");
    printUL($months);

}
function printUL($arrayOfLiTags)
{
    for ($i = 0; $i < count($arrayOfLiTags); $i++) {
        echo("<li style='text-decoration: underline;'>".$arrayOfLiTags[$i]."</li>");
    }
    echo("</ul>");
}
?>
