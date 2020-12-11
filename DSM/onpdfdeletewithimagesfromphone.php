<?php
 include("db_con.php");
 
 $id=$_POST['id'];
 $groupid=$_POST['groupid'];
 
 $sql="DELETE FROM DMSdata WHERE GroupID='$groupid'";
 $run=mysqli_query($con,$sql);

 if(mysqli_num_rows($run) > 0)
 {
   echo "success";
   
  }
  //just deleting from dmsdata table
  //TODO delete from image database
  //first image then datarows
  $con->close(); 
?>