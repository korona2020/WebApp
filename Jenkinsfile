pipeline{
    agent any
    environment {
                    msbuildHome = tool 'MSBuild'
                    
                }
    stages{
        
            stage ('Clean workspace') {
  	                steps {
    		                 cleanWs()
  	                      }
             }
        
            stage("Git Checkout"){
                    steps{
                             git branch: 'master', credentialsId: 'GitRepo', url: 'https://github.com/korona2020/WebApp.git'
                        }
             }
        
             stage('Restore packages') {
  		            steps {
    			            bat "dotnet restore ${workspace}\\WebApp.sln"
 		                 }
             } 
        
             stage('Clean SLN') {
                    steps {
                             bat "\"${msbuildHome}\\MSBuild.exe ${workspace}\\WebApp.sln" /nologo /nr:false /p:platform=\"x64\" /p:configuration=\"release\" /t:clean"
                          }
            }
        
        
          }
    }
