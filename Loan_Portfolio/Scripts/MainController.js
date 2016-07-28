app.controller("TableController",function($scope){
	$scope.num=1;
	$scope.RemoveRow=function(){
		$scope.num-=1;
	};
	$scope.AddRow=function(){
		$scope.num+=1;
	};
	$scope.range=function(n){
		return new Array(n);
	};
});
app.controller("TableController2",function($scope){
$scope.num=1;
	$scope.RemoveRow=function(){
		$scope.num-=1;
	};
	$scope.AddRow=function(){
		$scope.num+=1;
	};
	$scope.range=function(n){
		return new Array(n);
	};

});
