pipeline {
    agent any
    tools {
        dotnet 'dotnet7' // Ensure .NET 7 is available in Jenkins
    }
    environment {
        DOTNET_VERSION = '7.0'
    }
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/ChaimShtern/TryJenkins.git'
            }
        }
        stage('Restore Dependencies') {
            steps {
                script {
                    sh 'dotnet restore TryJenkins/TryJenkins.csproj'
                }
            }
        }
        stage('Build') {
            steps {
                script {
                    sh 'dotnet build TryJenkins/TryJenkins.csproj --no-restore'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    sh 'dotnet test TryJenkins.Tests/TryJenkins.Tests.csproj --no-build --logger trx'
                }
            }
        }
        stage('Run Application') {
            steps {
                script {
                    sh 'dotnet run --project TryJenkins/TryJenkins.csproj'
                }
            }
        }
    }
    post {
        success {
            echo 'Build and tests succeeded!'
        }
        failure {
            echo 'Build or tests failed!'
        }
    }
}

