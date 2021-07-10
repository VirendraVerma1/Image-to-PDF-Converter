<?php
 include("db_con.php");
 
 $id=$_POST['id'];
 $groupid=$_POST['groupid'];
 
 
 $sql="Select * from DMSdata where GroupID='$groupid'";
 $run=mysqli_query($con,$sql);

 if(mysqli_num_rows($run) > 0)
 {
   
   while($data=mysqli_fetch_assoc($run))
   {
       if($data['Process']==3)
       {
           $folder="Merged/".$data['UserID']."/".$data['GroupID']."/".$data['FileName'].".pdf";
           unlink($folder);
       }
    }
    
    $sql="Select * from DMSimagedata where GroupID='$groupid'";
    $run1=mysqli_query($con,$sql);
    
     if(mysqli_num_rows($run1) > 0)
     {
       
       while($data=mysqli_fetch_assoc($run1))
       {
           unlink('upload/'.$data['FileName']);
       }
     }
   
    $sql="DELETE FROM DMSdata WHERE GroupID='$groupid'";
    $run=mysqli_query($con,$sql);
 
    $sql="DELETE FROM DMSimagedata WHERE GroupID='$groupid'";
    $run=mysqli_query($con,$sql);
    echo "success";
 }
 
 
  //just deleting from dmsdata table
  //TODO delete from image database
  //first image then datarows
  
  $con->close(); 
?>