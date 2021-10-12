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
        stage('Clean') {
  		steps {
    			dotnetClean configuration: 'Release', project: 'WebApp.sln', sdk: '.NET 5.0', workDirectory: ${workspace}\\WebApp.sln
 		      }
        } 
        stage('Build') {
  		steps {
    			dotnetBuild configuration: 'Release', project: 'WebApp.sln', sdk: '.NET 5.0', workDirectory: 'C:\\Users\\Administrator\\AppData\\Local\\Jenkins\\.jenkins\\workspace\\WebApp'
 		      }
        } 
       
        
    }
    
}
