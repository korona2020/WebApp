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
    			dotnetClean configuration: 'Release', project: 'WebApp.sln', sdk: '.NET 5.0', workDirectory: 'C:\\Users\\Administrator\\AppData\\Local\\Jenkins\\.jenkins\\workspace\\WebApp'
 		      }
        } 
        stage('Build') {
  		steps {
    			dotnetBuild configuration: 'Release', project: 'WebApp.sln', sdk: '.NET 5.0', workDirectory: 'C:\\Users\\Administrator\\AppData\\Local\\Jenkins\\.jenkins\\workspace\\WebApp'
 		      }
        } 
       
        stage('Running Unit Tests') {
  		steps {
    			dotnetTest configuration: 'Release', project: 'WebApp.sln', sdk: '.NET 5.0', workDirectory: 'C:\\Users\\Administrator\\AppData\\Local\\Jenkins\\.jenkins\\workspace\\WebApp'
 		      }
       } 
       
        stage('Build + SonarQube analysis') {
            environment {
                msbuildHome = tool 'MSBuild'
                scannerHome = tool 'Scanner for MSBuild'
            }
            steps{
                        
                            withSonarQubeEnv('sq1') {
                                   bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" begin /k:\"test\""
                                   bat "\"${msbuildHome}\\MSBuild.exe\" /t:Rebuild"
                                   bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" end"
                            }
            }
        }
       
      
        
    }
    }
