<?php
 include("db_con.php");
 
 $id=$_POST['id'];
 $groupId=$_POST['groupId'];
 
 $sql="Select * from DMSdata Where UserID='$id' and GroupID='$groupId'";
 $run=mysqli_query($con,$sql);

 if(mysqli_num_rows($run) > 0)
 {
   
   $data=mysqli_fetch_assoc($run);
   if($data['Process']==3)//means pdf created
   {
           //create link for user to download
           echo "Link:"."https://datacontainernew.000webhostapp.com/DSM/Merged/".$id."/".$groupId."/".$data['FileName'].".pdf";
   }else if($data['Process']==2){
           echo "Wait";
   }
     
   
  }
  $con->close(); 
?>