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
	    
    }
}
