<?php
     include("db_con.php");
 
     $id=$_POST['id'];
     $group_id=$_POST['groupid'];
     $pdfcode=$_POST['pdfcode'];
     
     $sql="Select * from DMSdata where UserID='$id' and GroupID='$group_id' and PDFCode='$pdfcode'";
     $run=mysqli_query($con,$sql);
    
    if($run)
    {
        if(mysqli_num_rows($run) > 0)
        {
            $value=0;
            $data=mysqli_fetch_assoc($run);
            if($data['IsSharable']==0)
            $value=1;
            else
            $value=0;
            $sql="UPDATE DMSdata SET IsSharable = '$value' WHERE GroupID='$group_id' and UserID='$id' and PDFCode='$pdfcode'";
             $run=mysqli_query($con,$sql);
            
             if($run)
             {
                 if($value==1)
                    echo "success";
                    else
                    echo "seto";
               
             }else{
                  echo "failed";   
             }
        }
        else
        {
            echo "failed";
        }
    }
     
    $con->close(); 
?>