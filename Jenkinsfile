pipeline{
    
    agent any
    stages{
        stage("Git Checkout"){
            steps{
                git branch: 'master', credentialsId: 'TestGit', url: 'https://github.com/korona2020/WebApp.git'
            }
        }
	    stage ("Build"){
		    steps{
			 
		bat "\"${tool 'MSBuild'}\" WebApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"  
		    }
		
	    }
    }
}
