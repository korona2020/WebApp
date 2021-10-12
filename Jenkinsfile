pipeline{
    agent any
   
 stages{
	    
	stage ('Clean workspace') {
  	    steps {
    		cleanWs()
  	    }
         }
	    
        stage("Git Checkout"){
            steps{
                git branch: 'master', credentialsId: 'TestGit', url: 'https://github.com/korona2020/WebApp.git'
            }
        }
	stage('Restore packages') {
  		steps {
    			bat "dotnet restore ${workspace}\\WebApp.sln"
 		      }
        } 
	stage('Build') {
      steps {
        script {
          def msbuild = tool name: 'MSBuild'
          bat "${msbuild} C:\Users\Administrator\AppData\Local\Jenkins\.jenkins\workspace\WebApp\WebApp.sln"
        } 
      } 
    } 
	 
    }
}
