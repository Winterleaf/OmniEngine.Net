<?php
beginModule('walkabout');

	addProjectDefine("TORQUE_WALKABOUT_ENABLED");
	addProjectDefine("TORQUE_WALKABOUT_EXTRAS_ENABLED");
	addSrcDir(getEngineSrcDir() . 'walkabout', true);

	includeLib( 'librecast' );
	addLibIncludePath( 'recast/DebugUtils/Include' );
	addLibIncludePath( 'recast/Recast/Include' );
	addLibIncludePath( 'recast/Detour/Include' );
	addLibIncludePath( 'recast/DetourTileCache/Include' );
	addLibIncludePath( 'recast/DetourCrowd/Include' );

	if (inProjectConfig())
	{
		addProjectDependency( 'librecast' );
		addSolutionProjectRef( 'librecast' );
	}

endModule();
?>
