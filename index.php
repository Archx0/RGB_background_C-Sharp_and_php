<?php include "template/headr.php"; ?>
<?php
    function filterSting($field){
        $field = filter_var(trim($field) , FILTER_SANITIZE_STRING);
        if (empty($field)){
            return false;
        }else{
            return $field;
        }
    }
if ($_SERVER['REQUEST_METHOD'] == 'POST') {

    if (isset($_POST["inColor"]) ) {
        $V_red = $inRed = filterSting($_POST['red']);
        $V_green = $inGreen = filterSting($_POST['green']);
        $V_blue = $inBlue = filterSting($_POST['blue']);
        if (empty($V_red) || $V_red == 0){
            $V_red = 1;
        }
        if (empty($V_green) || $V_green == 0){
            $V_green = 1 ;
        }
        if(empty($V_blue) || $V_blue == 0){
            $V_blue = 1;
        }
    }
     if (isset($_POST["outColor"])){
    	$V_red = $outRed= filterSting($_POST['red']);
        $V_green = $outGreen =filterSting($_POST['green']);
        $V_blue =$outBlue = filterSting($_POST['blue']);
         if (empty($V_red) || $V_red == 0){
             $V_red = 1;
         }
         if (empty($V_green) || $V_green == 0){
             $V_green = 1 ;
         }
         if(empty($V_blue) || $V_blue == 0){
             $V_blue = 1;
         }
         }
    }
    ?>
  <body style="background:<?php echo "rgb($outRed,$outBlue,$outGreen)"?>">
	<div class="container-fluid position-relative  row h-100">
   <div class=" position-absolute col-12" style="background: <?php echo "rgb($inRed,$inBlue,$inGreen)"?> ">
    <form class="pt-5 pb-5 mt-5 h-100 container shadow-lg" action="<?php echo $_SERVER['PHP_SELF']?>" method="post">
        <div class="form-group ">
            <label class="text-danger">RED</label>
            <input type="number" name="red" value="<?php echo $V_red;?>" placeholder="red number" class="form-control text-danger">
        </div>
        <div class="form-group position-relative mt-5 ">
            <label class="text-success ">green</label>
            <input type="number" name="green" value="<?php echo $V_green;?>" placeholder="green number" class="form-control text-success">
        </div>
        <div class="form-group position-relative mt-5 ">
            <label class="text-primary">blue</label>
            <input type="number" name="blue" value="<?php echo $V_blue;?>" placeholder="blue number" class="form-control text-info">
        </div>
	    <div class="row container">
		<button class="btn btn-outline-info col"  id="LBtn" name="outColor" > Full body ! </button>
        <button class="btn btn-outline-warning col"  id="inBtn" name="inColor"> only up !</button>
	    </div>
    </form>
   </div>
<?php include "template/footer.php";?>