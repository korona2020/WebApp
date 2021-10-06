pipeline{
    environment {
    MSBUILD = "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin"
    CONFIG = 'Release'
    PLATFORM = 'x64'
  }
    agent any
    stages{
        stage("Git Checkout"){
            steps{
                git branch: 'master', credentialsId: 'TestGit', url: 'https://github.com/korona2020/WebApp.git'
            }
        }
        stage('Build') {
            steps {
                bat "NuGet.exe restore your_project.sln"
                bat "\"${MSBUILD}\" WebApp.sln /p:Configuration=${env.CONFIG};Platform=${env.PLATFORM} /maxcpucount:%NUMBER_OF_PROCESSORS% /nodeReuse:false"
      }
    }
}
