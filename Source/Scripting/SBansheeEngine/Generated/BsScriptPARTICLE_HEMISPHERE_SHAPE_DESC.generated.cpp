#include "BsScriptPARTICLE_HEMISPHERE_SHAPE_DESC.generated.h"
#include "BsMonoMethod.h"
#include "BsMonoClass.h"
#include "BsMonoUtil.h"

namespace bs
{
	ScriptPARTICLE_HEMISPHERE_SHAPE_DESC::ScriptPARTICLE_HEMISPHERE_SHAPE_DESC(MonoObject* managedInstance)
		:ScriptObject(managedInstance)
	{ }

	void ScriptPARTICLE_HEMISPHERE_SHAPE_DESC::initRuntimeData()
	{ }

	MonoObject*ScriptPARTICLE_HEMISPHERE_SHAPE_DESC::box(const PARTICLE_HEMISPHERE_SHAPE_DESC& value)
	{
		return MonoUtil::box(metaData.scriptClass->_getInternalClass(), (void*)&value);
	}

	PARTICLE_HEMISPHERE_SHAPE_DESC ScriptPARTICLE_HEMISPHERE_SHAPE_DESC::unbox(MonoObject* value)
	{
		return *(PARTICLE_HEMISPHERE_SHAPE_DESC*)MonoUtil::unbox(value);
	}

}
