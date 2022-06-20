pipeline{
  agent any
  
  stages{
    stage("build"){
      steps{
        echo'building the application...'
        script{
          def test = 2+2>3?'cool':'not cool'
          echo test
          echo 'Application build each 1 min'
        }
      }
    }
    stage("test"){
      steps{
         echo'testing the application...'

      }
    }
    stage("deploy"){
      steps{
        echo'deploying the application...'

      }
    }
  }
}
